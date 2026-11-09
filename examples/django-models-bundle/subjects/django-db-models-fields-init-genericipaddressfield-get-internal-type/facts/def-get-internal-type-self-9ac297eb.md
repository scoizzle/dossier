# Fact 9ac297eb

Store id: af288b32-d892-4088-93a2-da4bd6f8dc3e

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
- posted_at: `2026-11-09T23:44:50.1956250+00:00`

## Data

```json
{
  "end_line": 2347,
  "entity_kind": "method",
  "parent": "GenericIPAddressField",
  "start_line": 2346,
  "symbol": "GenericIPAddressField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2346,"selector":"L2346-L2347","symbol":"GenericIPAddressField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2347,
    "entity_kind": "method",
    "parent": "GenericIPAddressField",
    "start_line": 2346,
    "symbol": "GenericIPAddressField.get_internal_type"
  },
  "id": "af288b32-d892-4088-93a2-da4bd6f8dc3e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1956250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2346,
        "selector": "L2346-L2347",
        "symbol": "GenericIPAddressField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8a79cf28-503b-4afe-a2d4-9304010ed856",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
