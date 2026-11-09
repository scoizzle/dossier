# Fact 5ddaa8eb

Store id: 9e7e6f61-ef4b-46fd-9439-d08e5e77ddaa

## Text

```text
def query(self)
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
- posted_at: `2026-11-09T23:32:04.3063590+00:00`

## Data

```json
{
  "end_line": 391,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 385,
  "symbol": "QuerySet.query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":385,"selector":"L385-L391","symbol":"QuerySet.query"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 391,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 385,
    "symbol": "QuerySet.query"
  },
  "id": "9e7e6f61-ef4b-46fd-9439-d08e5e77ddaa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3063590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 385,
        "selector": "L385-L391",
        "symbol": "QuerySet.query"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "bc6d165a-d894-4bd6-9d8a-c9740fe6f072",
  "subject_name": "django/db/models/query::QuerySet.query",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def query(self)"
}
```
