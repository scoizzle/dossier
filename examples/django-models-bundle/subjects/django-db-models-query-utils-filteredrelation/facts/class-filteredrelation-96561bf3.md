# Fact 96561bf3

Store id: b8588148-a929-461c-b8d7-b95274a39661

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
- posted_at: `2026-11-09T23:44:56.7365440+00:00`

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
  "id": "b8588148-a929-461c-b8d7-b95274a39661",
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
    "posted_at": "2026-11-09T23:44:56.7365440+00:00"
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
  "subject_id": "d29dc076-cf1b-4c32-81d2-16c83289e868",
  "subject_name": "django/db/models/query_utils::FilteredRelation",
  "tags": [
    "entity:class"
  ],
  "text": "class FilteredRelation"
}
```
