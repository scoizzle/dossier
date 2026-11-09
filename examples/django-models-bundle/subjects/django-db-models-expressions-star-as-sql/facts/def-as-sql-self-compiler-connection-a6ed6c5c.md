# Fact a6ed6c5c

Store id: a98c5afd-0275-4b13-b72e-8841a27d4d6b

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
- posted_at: `2026-11-09T23:31:55.8785410+00:00`

## Data

```json
{
  "end_line": 1308,
  "entity_kind": "method",
  "parent": "Star",
  "start_line": 1307,
  "symbol": "Star.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1307,"selector":"L1307-L1308","symbol":"Star.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Star.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1308,
    "entity_kind": "method",
    "parent": "Star",
    "start_line": 1307,
    "symbol": "Star.as_sql"
  },
  "id": "a98c5afd-0275-4b13-b72e-8841a27d4d6b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8785410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1307,
        "selector": "L1307-L1308",
        "symbol": "Star.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ca63394e-b21a-42c1-8015-db65caf91d1e",
  "subject_name": "django/db/models/expressions::Star.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
