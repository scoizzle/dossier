# Fact f17a550d

Store id: ac4d392d-e8b6-412d-ad5e-52eb3543b55f

## Text

```text
def __init__(self, verbose_name=None, name=None, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.8340720+00:00`

## Data

```json
{
  "end_line": 2725,
  "entity_kind": "method",
  "parent": "URLField",
  "start_line": 2723,
  "symbol": "URLField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2723,"selector":"L2723-L2725","symbol":"URLField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::URLField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2725,
    "entity_kind": "method",
    "parent": "URLField",
    "start_line": 2723,
    "symbol": "URLField.__init__"
  },
  "id": "ac4d392d-e8b6-412d-ad5e-52eb3543b55f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8340720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2723,
        "selector": "L2723-L2725",
        "symbol": "URLField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "25e65157-489d-43b4-8569-40b61b1ceffc",
  "subject_name": "django/db/models/fields/__init__::URLField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, verbose_name=None, name=None, **kwargs)"
}
```
