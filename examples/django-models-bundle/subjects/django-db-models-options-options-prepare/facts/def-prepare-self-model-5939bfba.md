# Fact 5939bfba

Store id: e567eef1-d2c7-401d-bec7-299df3dca688

## Text

```text
def _prepare(self, model)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.9230340+00:00`

## Data

```json
{
  "end_line": 334,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 292,
  "symbol": "Options._prepare"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":292,"selector":"L292-L334","symbol":"Options._prepare"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options._prepare](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 334,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 292,
    "symbol": "Options._prepare"
  },
  "id": "e567eef1-d2c7-401d-bec7-299df3dca688",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9230340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 292,
        "selector": "L292-L334",
        "symbol": "Options._prepare"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "16ab8d27-0801-4c44-baea-e15072bd6952",
  "subject_name": "django/db/models/options::Options._prepare",
  "tags": [
    "entity:method"
  ],
  "text": "def _prepare(self, model)"
}
```
