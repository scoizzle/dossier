# Fact 90bd1e58

Store id: b2dcbe67-185c-4f01-9aab-628eb38f1f44

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
- posted_at: `2026-11-09T22:39:42.6178920+00:00`

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
  "id": "b2dcbe67-185c-4f01-9aab-628eb38f1f44",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6178920+00:00"
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
  "subject_id": "df509aab-2b21-4c80-b0e6-e1dde3582788",
  "subject_name": "django/db/models/fields/__init__::PositiveSmallIntegerField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
