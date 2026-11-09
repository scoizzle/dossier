# Fact dcec86e1

Store id: 317eb8e9-f102-4154-81fd-d05237169b05

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
- posted_at: `2026-11-09T22:39:40.3373870+00:00`

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
  "id": "317eb8e9-f102-4154-81fd-d05237169b05",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3373870+00:00"
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
  "subject_id": "2244fc9d-77a2-4ac4-b1d1-9029c031f597",
  "subject_name": "django/db/models/base::Model.arefresh_from_db",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def arefresh_from_db(self, using=None, fields=None, from_queryset=None)"
}
```
