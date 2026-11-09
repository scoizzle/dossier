# Fact 42b2ab4e

Store id: 6dbcd874-2b79-422e-b79a-82567614b565

## Text

```text
class Mod(FixDecimalInputMixin, NumericOutputFieldMixin, Func)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:01.7240530+00:00`

## Data

```json
{
  "end_line": 128,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 126,
  "symbol": "Mod"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":126,"selector":"L126-L128","symbol":"Mod"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Mod](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 128,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 126,
    "symbol": "Mod"
  },
  "id": "6dbcd874-2b79-422e-b79a-82567614b565",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7240530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 126,
        "selector": "L126-L128",
        "symbol": "Mod"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "f7db253c-285e-41ca-b03d-ed9597cb9a91",
  "subject_name": "django/db/models/functions/math::Mod",
  "tags": [
    "entity:class"
  ],
  "text": "class Mod(FixDecimalInputMixin, NumericOutputFieldMixin, Func)"
}
```
