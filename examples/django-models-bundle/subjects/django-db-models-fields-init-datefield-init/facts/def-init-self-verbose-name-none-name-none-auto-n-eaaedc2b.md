# Fact eaaedc2b

Store id: cf98ffb8-2899-42fb-b99a-04051585b624

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
- posted_at: `2026-11-09T22:39:42.4122940+00:00`

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
  "id": "cf98ffb8-2899-42fb-b99a-04051585b624",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4122940+00:00"
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
  "subject_id": "7071ca55-922a-4d57-90fa-38887091fd29",
  "subject_name": "django/db/models/fields/__init__::DateField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, auto_now=False, auto_now_add=False, **kwargs )"
}
```
