# Fact 78b8570b

Store id: 11c457c8-4c26-4c44-8048-726e18597b1f

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
- posted_at: `2026-11-09T22:39:46.2107810+00:00`

## Data

```json
{
  "end_line": 404,
  "entity_kind": "method",
  "parent": "TruncTime",
  "start_line": 400,
  "symbol": "TruncTime.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":400,"selector":"L400-L404","symbol":"TruncTime.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncTime.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 404,
    "entity_kind": "method",
    "parent": "TruncTime",
    "start_line": 400,
    "symbol": "TruncTime.as_sql"
  },
  "id": "11c457c8-4c26-4c44-8048-726e18597b1f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.2107810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 400,
        "selector": "L400-L404",
        "symbol": "TruncTime.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "7a9edb59-e863-4faa-9699-569b503e4730",
  "subject_name": "django/db/models/functions/datetime::TruncTime.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
