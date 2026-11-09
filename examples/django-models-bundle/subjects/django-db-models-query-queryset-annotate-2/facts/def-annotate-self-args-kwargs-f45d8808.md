# Fact f45d8808

Store id: eb72713f-57c2-4680-b668-3d4475a16a62

## Text

```text
def annotate(self, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:49.6484040+00:00`

## Data

```json
{
  "end_line": 1867,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1861,
  "symbol": "QuerySet.annotate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1861,"selector":"L1861-L1867","symbol":"QuerySet.annotate"}`

## Items

```json
[
  {
    "text": "Return a query set in which the returned objects have been annotated with extra data or aggregations.",
    "locator": {
      "line": 1862
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.annotate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1867,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1861,
    "symbol": "QuerySet.annotate"
  },
  "id": "eb72713f-57c2-4680-b668-3d4475a16a62",
  "items": [
    {
      "locator": {
        "line": 1862
      },
      "text": "Return a query set in which the returned objects have been annotated with extra data or aggregations."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6484040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1861,
        "selector": "L1861-L1867",
        "symbol": "QuerySet.annotate"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "81d19220-7344-46d1-af50-ec6d579dca65",
  "subject_name": "django/db/models/query::QuerySet.annotate",
  "tags": [
    "entity:method"
  ],
  "text": "def annotate(self, *args, **kwargs)"
}
```
