# Fact 841d93cf

Store id: 657a1781-bb9c-40c5-a53c-bc5cd1354fba

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
- posted_at: `2026-11-09T23:44:49.5665110+00:00`

## Data

```json
{
  "end_line": 1433,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1423,
  "symbol": "ColPairs.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1423,"selector":"L1423-L1433","symbol":"ColPairs.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1433,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1423,
    "symbol": "ColPairs.as_sql"
  },
  "id": "657a1781-bb9c-40c5-a53c-bc5cd1354fba",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5665110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1423,
        "selector": "L1423-L1433",
        "symbol": "ColPairs.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "641fc68e-de67-4141-8f37-2e492572b9a1",
  "subject_name": "django/db/models/expressions::ColPairs.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
