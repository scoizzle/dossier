# Fact 6ed79c0d

Store id: 535f93af-9a9f-446f-9c21-7cfc4be3d033

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
- posted_at: `2026-11-09T22:39:42.4307400+00:00`

## Data

```json
{
  "end_line": 1635,
  "entity_kind": "method",
  "parent": "DateTimeField",
  "start_line": 1634,
  "symbol": "DateTimeField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1634,"selector":"L1634-L1635","symbol":"DateTimeField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1635,
    "entity_kind": "method",
    "parent": "DateTimeField",
    "start_line": 1634,
    "symbol": "DateTimeField.get_internal_type"
  },
  "id": "535f93af-9a9f-446f-9c21-7cfc4be3d033",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4307400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1634,
        "selector": "L1634-L1635",
        "symbol": "DateTimeField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "2fc0779e-1ab3-4593-9812-07a35dd0f782",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
