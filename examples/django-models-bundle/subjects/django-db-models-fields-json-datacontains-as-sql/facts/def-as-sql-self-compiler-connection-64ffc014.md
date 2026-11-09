# Fact 64ffc014

Store id: a5119dfa-0ede-4000-9460-fe672a4d0a8d

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
- posted_at: `2026-11-09T22:39:43.6292590+00:00`

## Data

```json
{
  "end_line": 165,
  "entity_kind": "method",
  "parent": "DataContains",
  "start_line": 157,
  "symbol": "DataContains.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":157,"selector":"L157-L165","symbol":"DataContains.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::DataContains.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 165,
    "entity_kind": "method",
    "parent": "DataContains",
    "start_line": 157,
    "symbol": "DataContains.as_sql"
  },
  "id": "a5119dfa-0ede-4000-9460-fe672a4d0a8d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6292590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 157,
        "selector": "L157-L165",
        "symbol": "DataContains.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "ac24aa05-cdd1-4cd9-81fd-307cc2c4dc47",
  "subject_name": "django/db/models/fields/json::DataContains.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
