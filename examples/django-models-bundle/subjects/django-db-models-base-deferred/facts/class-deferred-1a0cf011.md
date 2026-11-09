# Fact 1a0cf011

Store id: 47ef4cbd-cef6-45b0-af30-759970a8ec75

## Text

```text
class Deferred
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
- posted_at: `2026-11-09T23:44:48.5079200+00:00`

## Data

```json
{
  "end_line": 66,
  "entity_kind": "class",
  "parent": "base",
  "start_line": 61,
  "symbol": "Deferred"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":61,"selector":"L61-L66","symbol":"Deferred"}`

## Referenced by

None.

## Subject

[django/db/models/base::Deferred](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 66,
    "entity_kind": "class",
    "parent": "base",
    "start_line": 61,
    "symbol": "Deferred"
  },
  "id": "47ef4cbd-cef6-45b0-af30-759970a8ec75",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5079200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 61,
        "selector": "L61-L66",
        "symbol": "Deferred"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "5dda8717-9a50-475f-9f18-0def7f48b95d",
  "subject_name": "django/db/models/base::Deferred",
  "tags": [
    "entity:class"
  ],
  "text": "class Deferred"
}
```
