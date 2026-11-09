# Fact b82bbbc9

Store id: 17f98526-9a1d-440f-bf56-d45d03e3fc57

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
- posted_at: `2026-11-09T23:32:06.7814560+00:00`

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
  "id": "17f98526-9a1d-440f-bf56-d45d03e3fc57",
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
    "posted_at": "2026-11-09T23:32:06.7814560+00:00"
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
  "subject_id": "06c0e5fb-55dd-4313-9188-0d3d80569fe5",
  "subject_name": "django/db/models/sql/query::Query.chain",
  "tags": [
    "entity:method"
  ],
  "text": "def chain(self, klass=None)"
}
```
