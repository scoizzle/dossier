# Fact 596d1567

Store id: a5c31987-2b53-4139-a57d-687665c1100b

## Text

```text
class Pi(NumericOutputFieldMixin, Func)
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
- posted_at: `2026-11-09T23:32:01.7269790+00:00`

## Data

```json
{
  "end_line": 138,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 131,
  "symbol": "Pi"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":131,"selector":"L131-L138","symbol":"Pi"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Pi](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 138,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 131,
    "symbol": "Pi"
  },
  "id": "a5c31987-2b53-4139-a57d-687665c1100b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7269790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 131,
        "selector": "L131-L138",
        "symbol": "Pi"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "4acd53c0-e952-4768-9733-fdfd9f67fff3",
  "subject_name": "django/db/models/functions/math::Pi",
  "tags": [
    "entity:class"
  ],
  "text": "class Pi(NumericOutputFieldMixin, Func)"
}
```
