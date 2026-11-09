# Fact 1acf9ad5

Store id: fd8521ad-c5ed-4d07-a0e1-ca873e21a0f7

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
- posted_at: `2026-11-09T23:44:50.1793330+00:00`

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
  "id": "fd8521ad-c5ed-4d07-a0e1-ca873e21a0f7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1793330+00:00"
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
  "subject_id": "a5437c41-fa3a-49cf-a742-18fab56eff10",
  "subject_name": "django/db/models/fields/__init__::IPAddressField",
  "tags": [
    "entity:class"
  ],
  "text": "class IPAddressField(Field)"
}
```
