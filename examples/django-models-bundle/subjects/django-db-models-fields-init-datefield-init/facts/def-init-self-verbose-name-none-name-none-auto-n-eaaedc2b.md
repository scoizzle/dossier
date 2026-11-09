# Fact eaaedc2b

Store id: 581f305d-1dda-4cf6-8943-b0ea8ab6d9b7

## Text

```text
def __init__( self, verbose_name=None, name=None, auto_now=False, auto_now_add=False, **kwargs )
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
- posted_at: `2026-11-09T23:44:50.0860730+00:00`

## Data

```json
{
  "end_line": 1485,
  "entity_kind": "method",
  "parent": "DateField",
  "start_line": 1478,
  "symbol": "DateField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1478,"selector":"L1478-L1485","symbol":"DateField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1485,
    "entity_kind": "method",
    "parent": "DateField",
    "start_line": 1478,
    "symbol": "DateField.__init__"
  },
  "id": "581f305d-1dda-4cf6-8943-b0ea8ab6d9b7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0860730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1478,
        "selector": "L1478-L1485",
        "symbol": "DateField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "bb043ae0-94a4-49a5-85ff-6979375ee1fc",
  "subject_name": "django/db/models/fields/__init__::DateField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, auto_now=False, auto_now_add=False, **kwargs )"
}
```
