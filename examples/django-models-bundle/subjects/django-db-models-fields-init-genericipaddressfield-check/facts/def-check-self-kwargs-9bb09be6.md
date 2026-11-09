# Fact 9bb09be6

Store id: 3e6396c8-c57b-49c9-b962-8eab98af690b

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.5768890+00:00`

## Data

```json
{
  "end_line": 2322,
  "entity_kind": "method",
  "parent": "GenericIPAddressField",
  "start_line": 2318,
  "symbol": "GenericIPAddressField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2318,"selector":"L2318-L2322","symbol":"GenericIPAddressField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::GenericIPAddressField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2322,
    "entity_kind": "method",
    "parent": "GenericIPAddressField",
    "start_line": 2318,
    "symbol": "GenericIPAddressField.check"
  },
  "id": "3e6396c8-c57b-49c9-b962-8eab98af690b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5768890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2318,
        "selector": "L2318-L2322",
        "symbol": "GenericIPAddressField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8f08c05f-2f46-46e3-a93d-d186c3c53e95",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
