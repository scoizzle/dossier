# Fact 69d7a011

Store id: c03ffb0a-35d9-4666-86bf-a96345e22661

## Text

```text
def get(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:55.8942440+00:00`

## Data

```json
{
  "end_line": 731,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 698,
  "symbol": "QuerySet.get"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":698,"selector":"L698-L731","symbol":"QuerySet.get"}`

## Items

```json
[
  {
    "text": "Perform the query and return a single object matching the given keyword arguments.",
    "locator": {
      "line": 699
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.get](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 731,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 698,
    "symbol": "QuerySet.get"
  },
  "id": "c03ffb0a-35d9-4666-86bf-a96345e22661",
  "items": [
    {
      "locator": {
        "line": 699
      },
      "text": "Perform the query and return a single object matching the given keyword arguments."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8942440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 698,
        "selector": "L698-L731",
        "symbol": "QuerySet.get"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "15eced46-7451-4384-bbf3-c1d1a1a9c364",
  "subject_name": "django/db/models/query::QuerySet.get",
  "tags": [
    "entity:method"
  ],
  "text": "def get(self, *args, **kwargs)"
}
```
