# Fact d46b7849

Store id: f4b99ed3-329e-4790-854e-11c4b31b00bf

## Text

```text
def set_empty(self)
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
- posted_at: `2026-11-09T22:39:51.4350520+00:00`

## Data

```json
{
  "end_line": 2184,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2181,
  "symbol": "Query.set_empty"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2181,"selector":"L2181-L2184","symbol":"Query.set_empty"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.set_empty](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2184,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2181,
    "symbol": "Query.set_empty"
  },
  "id": "f4b99ed3-329e-4790-854e-11c4b31b00bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4350520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2181,
        "selector": "L2181-L2184",
        "symbol": "Query.set_empty"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "27d692ce-0b2f-4298-982a-725312eeda4f",
  "subject_name": "django/db/models/sql/query::Query.set_empty",
  "tags": [
    "entity:method"
  ],
  "text": "def set_empty(self)"
}
```
