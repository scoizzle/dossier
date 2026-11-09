# Fact 90bd1e58

Store id: c4060cde-4ab3-4f03-a34b-e6da20304f75

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:44:50.2232970+00:00`

## Data

```json
{
  "end_line": 2476,
  "entity_kind": "method",
  "parent": "PositiveSmallIntegerField",
  "start_line": 2475,
  "symbol": "PositiveSmallIntegerField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2475,"selector":"L2475-L2476","symbol":"PositiveSmallIntegerField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::PositiveSmallIntegerField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2476,
    "entity_kind": "method",
    "parent": "PositiveSmallIntegerField",
    "start_line": 2475,
    "symbol": "PositiveSmallIntegerField.get_internal_type"
  },
  "id": "c4060cde-4ab3-4f03-a34b-e6da20304f75",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2232970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2475,
        "selector": "L2475-L2476",
        "symbol": "PositiveSmallIntegerField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "748dd1ad-d69d-4690-af18-964a82d2d6ae",
  "subject_name": "django/db/models/fields/__init__::PositiveSmallIntegerField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
