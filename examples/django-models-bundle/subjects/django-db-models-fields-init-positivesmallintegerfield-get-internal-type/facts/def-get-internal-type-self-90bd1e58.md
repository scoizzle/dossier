# Fact 90bd1e58

Store id: 5b32c4bf-a0bf-4d39-9974-d74316989f7f

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
- posted_at: `2026-11-09T23:31:56.7776460+00:00`

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
  "id": "5b32c4bf-a0bf-4d39-9974-d74316989f7f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7776460+00:00"
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
  "subject_id": "631b0262-7e3e-4404-9d36-c5cfd14e2d78",
  "subject_name": "django/db/models/fields/__init__::PositiveSmallIntegerField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
