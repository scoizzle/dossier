# Fact 46b6c3ec

Store id: ca5f69a6-c695-411f-8132-08c1fb1d7195

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
- posted_at: `2026-11-09T22:39:42.6560510+00:00`

## Data

```json
{
  "end_line": 2622,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2615,
  "symbol": "TimeField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2615,"selector":"L2615-L2622","symbol":"TimeField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2622,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2615,
    "symbol": "TimeField.__init__"
  },
  "id": "ca5f69a6-c695-411f-8132-08c1fb1d7195",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6560510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2615,
        "selector": "L2615-L2622",
        "symbol": "TimeField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1748ae6c-7baf-490b-9c0b-17368bfe72d9",
  "subject_name": "django/db/models/fields/__init__::TimeField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, auto_now=False, auto_now_add=False, **kwargs )"
}
```
