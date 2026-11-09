# Fact eaaedc2b

Store id: 93eef873-420d-4dea-a3fa-0038192a4340

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
- posted_at: `2026-11-09T23:31:56.5758000+00:00`

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
  "id": "93eef873-420d-4dea-a3fa-0038192a4340",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5758000+00:00"
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
  "subject_id": "873b4159-b48b-4ad0-8d24-ed6ea18c31d1",
  "subject_name": "django/db/models/fields/__init__::DateField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, auto_now=False, auto_now_add=False, **kwargs )"
}
```
