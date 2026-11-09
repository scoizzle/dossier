# Fact 9bb09be6

Store id: 23f0f8a5-ef61-4cbc-a200-ae64aa603c5d

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
- posted_at: `2026-11-09T23:44:50.1906000+00:00`

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
  "id": "23f0f8a5-ef61-4cbc-a200-ae64aa603c5d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1906000+00:00"
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
  "subject_id": "25f5c8fa-ce7a-48c1-9fff-d040b8bcaa0d",
  "subject_name": "django/db/models/fields/__init__::GenericIPAddressField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
