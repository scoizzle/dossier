# Fact d6534e54

Store id: f028e80a-7ccf-4aa4-9136-73de53925446

## Text

```text
def select_related(self, *fields)
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
- posted_at: `2026-11-09T23:44:56.0645910+00:00`

## Data

```json
{
  "end_line": 1834,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1804,
  "symbol": "QuerySet.select_related"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1804,"selector":"L1804-L1834","symbol":"QuerySet.select_related"}`

## Items

```json
[
  {
    "text": "Return a new QuerySet instance that will select related objects.",
    "locator": {
      "line": 1805
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.select_related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1834,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1804,
    "symbol": "QuerySet.select_related"
  },
  "id": "f028e80a-7ccf-4aa4-9136-73de53925446",
  "items": [
    {
      "locator": {
        "line": 1805
      },
      "text": "Return a new QuerySet instance that will select related objects."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.0645910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1804,
        "selector": "L1804-L1834",
        "symbol": "QuerySet.select_related"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2a3b564d-8ea1-4117-8716-2b79ffbd0465",
  "subject_name": "django/db/models/query::QuerySet.select_related",
  "tags": [
    "entity:method"
  ],
  "text": "def select_related(self, *fields)"
}
```
