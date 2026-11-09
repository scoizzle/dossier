# Fact d84741b5

Store id: 873d9942-22c4-4e80-a67d-903b23bc30e2

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:31:56.7233930+00:00`

## Data

```json
{
  "end_line": 2284,
  "entity_kind": "method",
  "parent": "IPAddressField",
  "start_line": 2281,
  "symbol": "IPAddressField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2281,"selector":"L2281-L2284","symbol":"IPAddressField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IPAddressField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2284,
    "entity_kind": "method",
    "parent": "IPAddressField",
    "start_line": 2281,
    "symbol": "IPAddressField.deconstruct"
  },
  "id": "873d9942-22c4-4e80-a67d-903b23bc30e2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7233930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2281,
        "selector": "L2281-L2284",
        "symbol": "IPAddressField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "81cf47cc-eb4a-4d3b-9d28-b45a4b4cdca3",
  "subject_name": "django/db/models/fields/__init__::IPAddressField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
