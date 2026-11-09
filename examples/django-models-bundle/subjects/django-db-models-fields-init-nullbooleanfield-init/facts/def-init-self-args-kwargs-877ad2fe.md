# Fact 877ad2fe

Store id: 150edee3-4d1e-45d8-96dd-8846c5dc17cf

## Text

```text
def __init__(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.2051220+00:00`

## Data

```json
{
  "end_line": 2405,
  "entity_kind": "method",
  "parent": "NullBooleanField",
  "start_line": 2402,
  "symbol": "NullBooleanField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2402,"selector":"L2402-L2405","symbol":"NullBooleanField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::NullBooleanField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2405,
    "entity_kind": "method",
    "parent": "NullBooleanField",
    "start_line": 2402,
    "symbol": "NullBooleanField.__init__"
  },
  "id": "150edee3-4d1e-45d8-96dd-8846c5dc17cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2051220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2402,
        "selector": "L2402-L2405",
        "symbol": "NullBooleanField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "70ac5bf7-4e02-4085-9a88-737d7ed8ccfd",
  "subject_name": "django/db/models/fields/__init__::NullBooleanField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
