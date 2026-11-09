# Fact dfcd3e31

Store id: 3568c810-0041-4bda-b1c2-20c6b9ece6df

## Text

```text
def _merge_known_related_objects(self, other)
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
- posted_at: `2026-11-09T22:39:49.7259640+00:00`

## Data

```json
{
  "end_line": 2322,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2317,
  "symbol": "QuerySet._merge_known_related_objects"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2317,"selector":"L2317-L2322","symbol":"QuerySet._merge_known_related_objects"}`

## Items

```json
[
  {
    "text": "Keep track of all known related objects from either QuerySet instance.",
    "locator": {
      "line": 2318
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._merge_known_related_objects](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2322,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2317,
    "symbol": "QuerySet._merge_known_related_objects"
  },
  "id": "3568c810-0041-4bda-b1c2-20c6b9ece6df",
  "items": [
    {
      "locator": {
        "line": 2318
      },
      "text": "Keep track of all known related objects from either QuerySet instance."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7259640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2317,
        "selector": "L2317-L2322",
        "symbol": "QuerySet._merge_known_related_objects"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d55c9ba6-8343-4075-b253-35a9ce6717fa",
  "subject_name": "django/db/models/query::QuerySet._merge_known_related_objects",
  "tags": [
    "entity:method"
  ],
  "text": "def _merge_known_related_objects(self, other)"
}
```
