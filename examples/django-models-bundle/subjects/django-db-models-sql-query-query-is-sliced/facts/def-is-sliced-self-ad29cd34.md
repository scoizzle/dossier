# Fact ad29cd34

Store id: 77545a80-c5c3-44fb-9f53-ce312fe0eadc

## Text

```text
def is_sliced(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:07.0259020+00:00`

## Data

```json
{
  "end_line": 2218,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2216,
  "symbol": "Query.is_sliced"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2216,"selector":"L2216-L2218","symbol":"Query.is_sliced"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.is_sliced](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2218,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2216,
    "symbol": "Query.is_sliced"
  },
  "id": "77545a80-c5c3-44fb-9f53-ce312fe0eadc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.0259020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2216,
        "selector": "L2216-L2218",
        "symbol": "Query.is_sliced"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "52fcbb74-f3f1-4e30-8be1-6c49b98cd161",
  "subject_name": "django/db/models/sql/query::Query.is_sliced",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def is_sliced(self)"
}
```
