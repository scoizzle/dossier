# Fact 46b6c3ec

Store id: 39bfa677-567d-4374-b946-02960d43cfd0

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
- posted_at: `2026-11-09T23:31:56.8123710+00:00`

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
  "id": "39bfa677-567d-4374-b946-02960d43cfd0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8123710+00:00"
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
  "subject_id": "7a4e3a53-b82c-4cbe-bed5-dd3a6c4809b3",
  "subject_name": "django/db/models/fields/__init__::TimeField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, auto_now=False, auto_now_add=False, **kwargs )"
}
```
