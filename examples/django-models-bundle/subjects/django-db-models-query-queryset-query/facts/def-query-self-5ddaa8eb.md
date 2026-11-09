# Fact 5ddaa8eb

Store id: 0345840b-bf74-484f-a50f-cca014631cab

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
- posted_at: `2026-11-09T23:44:55.8296190+00:00`

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
  "id": "0345840b-bf74-484f-a50f-cca014631cab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8296190+00:00"
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
  "subject_id": "c54350e8-cbf0-403c-875d-e6a19cb8aa92",
  "subject_name": "django/db/models/query::QuerySet.query",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def query(self)"
}
```
