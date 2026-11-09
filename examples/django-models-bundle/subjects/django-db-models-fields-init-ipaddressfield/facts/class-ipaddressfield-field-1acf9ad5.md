# Fact 1acf9ad5

Store id: 188a6563-46b0-40a1-a730-bc264eaa4abb

## Text

```text
class IPAddressField(Field)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:42.5585510+00:00`

## Data

```json
{
  "end_line": 2293,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2265,
  "symbol": "IPAddressField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2265,"selector":"L2265-L2293","symbol":"IPAddressField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IPAddressField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2293,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2265,
    "symbol": "IPAddressField"
  },
  "id": "188a6563-46b0-40a1-a730-bc264eaa4abb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5585510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2265,
        "selector": "L2265-L2293",
        "symbol": "IPAddressField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9daf16cd-ee88-454b-9def-1971b5caf162",
  "subject_name": "django/db/models/fields/__init__::IPAddressField",
  "tags": [
    "entity:class"
  ],
  "text": "class IPAddressField(Field)"
}
```
