# Fact dfcd3e31

Store id: 68010652-d93b-4c76-9928-0928c03d253b

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
- posted_at: `2026-11-09T23:32:04.6568590+00:00`

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
  "id": "68010652-d93b-4c76-9928-0928c03d253b",
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
    "posted_at": "2026-11-09T23:32:04.6568590+00:00"
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
  "subject_id": "cf8858b8-0dba-4a75-a6f4-647738544af4",
  "subject_name": "django/db/models/query::QuerySet._merge_known_related_objects",
  "tags": [
    "entity:method"
  ],
  "text": "def _merge_known_related_objects(self, other)"
}
```
