# Fact fee8f3c4

Store id: 037719b0-7f96-4fa5-a23c-a23f0de89fd4

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
- posted_at: `2026-11-09T22:39:46.2053080+00:00`

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
  "id": "037719b0-7f96-4fa5-a23c-a23f0de89fd4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.2053080+00:00"
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
  "subject_id": "87f5019c-7860-4f22-9e34-8f31e22c695b",
  "subject_name": "django/db/models/functions/datetime::TruncDate.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
