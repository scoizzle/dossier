# Fact a91c9bf6

Store id: a85c763a-e533-42d1-a9e1-ba9292062739

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
- posted_at: `2026-11-09T22:39:41.6048180+00:00`

## Data

```json
{
  "end_line": 1260,
  "entity_kind": "method",
  "parent": "JSONNull",
  "start_line": 1256,
  "symbol": "JSONNull.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1256,"selector":"L1256-L1260","symbol":"JSONNull.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::JSONNull.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1260,
    "entity_kind": "method",
    "parent": "JSONNull",
    "start_line": 1256,
    "symbol": "JSONNull.as_sql"
  },
  "id": "a85c763a-e533-42d1-a9e1-ba9292062739",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6048180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1256,
        "selector": "L1256-L1260",
        "symbol": "JSONNull.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "7fd22698-f62c-4784-8450-6aa5353daaa8",
  "subject_name": "django/db/models/expressions::JSONNull.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
