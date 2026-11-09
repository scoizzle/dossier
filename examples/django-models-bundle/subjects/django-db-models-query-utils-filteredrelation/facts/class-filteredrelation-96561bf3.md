# Fact 96561bf3

Store id: c0f34a79-a453-4669-9634-3edb4c50818b

## Text

```text
class FilteredRelation
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
- posted_at: `2026-11-09T23:32:05.2003060+00:00`

## Data

```json
{
  "end_line": 570,
  "entity_kind": "class",
  "parent": "query_utils",
  "start_line": 520,
  "symbol": "FilteredRelation"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":520,"selector":"L520-L570","symbol":"FilteredRelation"}`

## Items

```json
[
  {
    "text": "Specify custom filtering in the ON clause of SQL joins.",
    "locator": {
      "line": 521
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::FilteredRelation](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 570,
    "entity_kind": "class",
    "parent": "query_utils",
    "start_line": 520,
    "symbol": "FilteredRelation"
  },
  "id": "c0f34a79-a453-4669-9634-3edb4c50818b",
  "items": [
    {
      "locator": {
        "line": 521
      },
      "text": "Specify custom filtering in the ON clause of SQL joins."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.2003060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 520,
        "selector": "L520-L570",
        "symbol": "FilteredRelation"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "db5c187d-a941-4ad4-ab05-7016cf75652f",
  "subject_name": "django/db/models/query_utils::FilteredRelation",
  "tags": [
    "entity:class"
  ],
  "text": "class FilteredRelation"
}
```
