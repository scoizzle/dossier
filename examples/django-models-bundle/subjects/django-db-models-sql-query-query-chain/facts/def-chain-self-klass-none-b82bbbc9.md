# Fact b82bbbc9

Store id: 6dc7f85a-534a-4372-934d-39c37059f2d7

## Text

```text
def chain(self, klass=None)
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
- posted_at: `2026-11-09T22:39:51.2469640+00:00`

## Data

```json
{
  "end_line": 445,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 432,
  "symbol": "Query.chain"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":432,"selector":"L432-L445","symbol":"Query.chain"}`

## Items

```json
[
  {
    "text": "Return a copy of the current Query that's ready for another operation. The klass argument changes the type of the Query, e.g. UpdateQuery.",
    "locator": {
      "line": 433
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.chain](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 445,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 432,
    "symbol": "Query.chain"
  },
  "id": "6dc7f85a-534a-4372-934d-39c37059f2d7",
  "items": [
    {
      "locator": {
        "line": 433
      },
      "text": "Return a copy of the current Query that's ready for another operation. The klass argument changes the type of the Query, e.g. UpdateQuery."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2469640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 432,
        "selector": "L432-L445",
        "symbol": "Query.chain"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "7492a3a1-4e3c-46d6-800e-dbbdc2a8a5ba",
  "subject_name": "django/db/models/sql/query::Query.chain",
  "tags": [
    "entity:method"
  ],
  "text": "def chain(self, klass=None)"
}
```
