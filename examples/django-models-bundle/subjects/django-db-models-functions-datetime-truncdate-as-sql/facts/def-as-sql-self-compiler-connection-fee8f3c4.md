# Fact fee8f3c4

Store id: 62a78b08-92b9-4eb8-8b86-b00e7644b3d7

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:32:01.2908190+00:00`

## Data

```json
{
  "end_line": 392,
  "entity_kind": "method",
  "parent": "TruncDate",
  "start_line": 388,
  "symbol": "TruncDate.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":388,"selector":"L388-L392","symbol":"TruncDate.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncDate.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 392,
    "entity_kind": "method",
    "parent": "TruncDate",
    "start_line": 388,
    "symbol": "TruncDate.as_sql"
  },
  "id": "62a78b08-92b9-4eb8-8b86-b00e7644b3d7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2908190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 388,
        "selector": "L388-L392",
        "symbol": "TruncDate.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "4a5f4851-eacd-4e6a-b5ba-377e9d5548cf",
  "subject_name": "django/db/models/functions/datetime::TruncDate.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
