# Fact dcec86e1

Store id: c669d4f6-ed6b-414d-a382-f803b6556b06

## Text

```text
async def arefresh_from_db(self, using=None, fields=None, from_queryset=None)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.5320570+00:00`

## Data

```json
{
  "end_line": 822,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 819,
  "symbol": "Model.arefresh_from_db"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":819,"selector":"L819-L822","symbol":"Model.arefresh_from_db"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.arefresh_from_db](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 822,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 819,
    "symbol": "Model.arefresh_from_db"
  },
  "id": "c669d4f6-ed6b-414d-a382-f803b6556b06",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5320570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 819,
        "selector": "L819-L822",
        "symbol": "Model.arefresh_from_db"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "793fd7e7-44fe-4351-8857-68eb434103b3",
  "subject_name": "django/db/models/base::Model.arefresh_from_db",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def arefresh_from_db(self, using=None, fields=None, from_queryset=None)"
}
```
