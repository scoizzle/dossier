# Fact 180cd123

Store id: e359d0cc-31ae-4e91-93a9-515e8309cbe3

## Text

```text
class FlatValuesListIterable(BaseIterable)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.2807710+00:00`

## Data

```json
{
  "end_line": 339,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 327,
  "symbol": "FlatValuesListIterable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":327,"selector":"L327-L339","symbol":"FlatValuesListIterable"}`

## Items

```json
[
  {
    "text": "Iterable returned by QuerySet.values_list(flat=True) that yields single values.",
    "locator": {
      "line": 328
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::FlatValuesListIterable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 339,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 327,
    "symbol": "FlatValuesListIterable"
  },
  "id": "e359d0cc-31ae-4e91-93a9-515e8309cbe3",
  "items": [
    {
      "locator": {
        "line": 328
      },
      "text": "Iterable returned by QuerySet.values_list(flat=True) that yields single values."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2807710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 327,
        "selector": "L327-L339",
        "symbol": "FlatValuesListIterable"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a52946d2-eebd-4cd9-bb56-57ab1a5d143a",
  "subject_name": "django/db/models/query::FlatValuesListIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class FlatValuesListIterable(BaseIterable)"
}
```
