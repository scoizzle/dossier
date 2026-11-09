# Fact 841d93cf

Store id: d6152901-83ca-4631-ae38-7ffe3bf5753f

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
- posted_at: `2026-11-09T22:39:41.6456240+00:00`

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
  "id": "d6152901-83ca-4631-ae38-7ffe3bf5753f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6456240+00:00"
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
  "subject_id": "049859ae-0501-44de-96ad-d7cffb34c218",
  "subject_name": "django/db/models/expressions::ColPairs.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
