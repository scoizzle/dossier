# Fact 6166c9db

Store id: fe8ba873-2865-4f84-b671-3c66965da166

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
- posted_at: `2026-11-09T23:31:55.8742310+00:00`

## Data

```json
{
  "end_line": 1281,
  "entity_kind": "method",
  "parent": "RawSQL",
  "start_line": 1280,
  "symbol": "RawSQL.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1280,"selector":"L1280-L1281","symbol":"RawSQL.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::RawSQL.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1281,
    "entity_kind": "method",
    "parent": "RawSQL",
    "start_line": 1280,
    "symbol": "RawSQL.as_sql"
  },
  "id": "fe8ba873-2865-4f84-b671-3c66965da166",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8742310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1280,
        "selector": "L1280-L1281",
        "symbol": "RawSQL.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "97e4b68f-b722-44ff-a97f-8ecdf7913d72",
  "subject_name": "django/db/models/expressions::RawSQL.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
