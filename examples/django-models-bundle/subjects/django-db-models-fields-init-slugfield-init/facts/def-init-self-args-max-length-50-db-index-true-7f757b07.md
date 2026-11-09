# Fact 7f757b07

Store id: b483e709-ef36-4809-8da5-04b52a5cdf9e

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
- posted_at: `2026-11-09T23:44:50.2275280+00:00`

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
  "id": "b483e709-ef36-4809-8da5-04b52a5cdf9e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2275280+00:00"
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
  "subject_id": "6bc73aa4-80d7-4785-991a-dc59636a16f7",
  "subject_name": "django/db/models/fields/__init__::SlugField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, *args, max_length=50, db_index=True, allow_unicode=False, **kwargs )"
}
```
