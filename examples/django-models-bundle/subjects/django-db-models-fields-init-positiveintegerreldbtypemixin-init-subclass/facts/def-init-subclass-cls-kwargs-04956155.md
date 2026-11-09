# Fact 04956155

Store id: 88724e41-e31f-4c8e-a6e0-0b4198bec96b

## Text

```text
def __init_subclass__(cls, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.7616800+00:00`

## Data

```json
{
  "end_line": 2425,
  "entity_kind": "method",
  "parent": "PositiveIntegerRelDbTypeMixin",
  "start_line": 2415,
  "symbol": "PositiveIntegerRelDbTypeMixin.__init_subclass__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2415,"selector":"L2415-L2425","symbol":"PositiveIntegerRelDbTypeMixin.__init_subclass__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::PositiveIntegerRelDbTypeMixin.__init_subclass__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2425,
    "entity_kind": "method",
    "parent": "PositiveIntegerRelDbTypeMixin",
    "start_line": 2415,
    "symbol": "PositiveIntegerRelDbTypeMixin.__init_subclass__"
  },
  "id": "88724e41-e31f-4c8e-a6e0-0b4198bec96b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7616800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2415,
        "selector": "L2415-L2425",
        "symbol": "PositiveIntegerRelDbTypeMixin.__init_subclass__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "fae92a2f-5a2c-4408-a9b2-1395a0d931fb",
  "subject_name": "django/db/models/fields/__init__::PositiveIntegerRelDbTypeMixin.__init_subclass__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init_subclass__(cls, **kwargs)"
}
```
