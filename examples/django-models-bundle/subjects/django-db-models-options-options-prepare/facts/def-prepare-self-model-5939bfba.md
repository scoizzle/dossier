# Fact 5939bfba

Store id: 47ef3e74-f6fd-4b01-a196-32a74c1a098f

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
- posted_at: `2026-11-09T23:44:55.4854550+00:00`

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
  "id": "47ef3e74-f6fd-4b01-a196-32a74c1a098f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4854550+00:00"
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
  "subject_id": "304b3877-dcb3-49b0-9a59-5ad286cb1467",
  "subject_name": "django/db/models/options::Options._prepare",
  "tags": [
    "entity:method"
  ],
  "text": "def _prepare(self, model)"
}
```
