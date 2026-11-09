# Fact 7f757b07

Store id: 85353d6f-e72d-4406-b399-ff0b8b30fc74

## Text

```text
def __init__( self, *args, max_length=50, db_index=True, allow_unicode=False, **kwargs )
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
- posted_at: `2026-11-09T22:39:42.6240300+00:00`

## Data

```json
{
  "end_line": 2497,
  "entity_kind": "method",
  "parent": "SlugField",
  "start_line": 2491,
  "symbol": "SlugField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2491,"selector":"L2491-L2497","symbol":"SlugField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SlugField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2497,
    "entity_kind": "method",
    "parent": "SlugField",
    "start_line": 2491,
    "symbol": "SlugField.__init__"
  },
  "id": "85353d6f-e72d-4406-b399-ff0b8b30fc74",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6240300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2491,
        "selector": "L2491-L2497",
        "symbol": "SlugField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "082d4328-d509-4f1a-9e0d-44c95b8db287",
  "subject_name": "django/db/models/fields/__init__::SlugField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *args, max_length=50, db_index=True, allow_unicode=False, **kwargs )"
}
```
