# Fact 0ccf037d

Store id: 517a7379-901a-4dc8-b434-64efa1a1cc92

## Text

```text
def _check_if_value_fixed(self, value, now=None)
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
- posted_at: `2026-11-09T22:39:42.4090380+00:00`

## Data

```json
{
  "end_line": 1461,
  "entity_kind": "method",
  "parent": "DateTimeCheckMixin",
  "start_line": 1429,
  "symbol": "DateTimeCheckMixin._check_if_value_fixed"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1429,"selector":"L1429-L1461","symbol":"DateTimeCheckMixin._check_if_value_fixed"}`

## Items

```json
[
  {
    "text": "Check if the given value appears to have been provided as a \"fixed\" time value, and include a warning in the returned list if it does. The value argument must be a date object or aware/naive datetime object. If now is provided, it must be a naive datetime object.",
    "locator": {
      "line": 1430
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeCheckMixin._check_if_value_fixed](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1461,
    "entity_kind": "method",
    "parent": "DateTimeCheckMixin",
    "start_line": 1429,
    "symbol": "DateTimeCheckMixin._check_if_value_fixed"
  },
  "id": "517a7379-901a-4dc8-b434-64efa1a1cc92",
  "items": [
    {
      "locator": {
        "line": 1430
      },
      "text": "Check if the given value appears to have been provided as a \"fixed\" time value, and include a warning in the returned list if it does. The value argument must be a date object or aware/naive datetime object. If now is provided, it must be a naive datetime object."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4090380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1429,
        "selector": "L1429-L1461",
        "symbol": "DateTimeCheckMixin._check_if_value_fixed"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "39cca0de-b0b5-47e0-9845-0be3ca8f4ec7",
  "subject_name": "django/db/models/fields/__init__::DateTimeCheckMixin._check_if_value_fixed",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_if_value_fixed(self, value, now=None)"
}
```
