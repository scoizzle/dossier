# Fact 7f757b07

Store id: 5b2fdf58-6adf-439b-8bd0-d3363035848d

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
- posted_at: `2026-11-09T23:31:56.7841200+00:00`

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
  "id": "5b2fdf58-6adf-439b-8bd0-d3363035848d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7841200+00:00"
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
  "subject_id": "cc46d9dc-e30d-49cd-97b3-fd7d8d85b2d0",
  "subject_name": "django/db/models/fields/__init__::SlugField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *args, max_length=50, db_index=True, allow_unicode=False, **kwargs )"
}
```
