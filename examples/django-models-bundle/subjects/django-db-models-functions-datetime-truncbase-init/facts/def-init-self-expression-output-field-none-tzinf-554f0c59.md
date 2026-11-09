# Fact 554f0c59

Store id: 526595ca-3b2e-4b06-9031-0fcfedbd13f1

## Text

```text
def __init__( self, expression, output_field=None, tzinfo=None, **extra, )
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
- posted_at: `2026-11-09T22:39:46.1754220+00:00`

## Data

```json
{
  "end_line": 256,
  "entity_kind": "method",
  "parent": "TruncBase",
  "start_line": 248,
  "symbol": "TruncBase.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":248,"selector":"L248-L256","symbol":"TruncBase.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncBase.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 256,
    "entity_kind": "method",
    "parent": "TruncBase",
    "start_line": 248,
    "symbol": "TruncBase.__init__"
  },
  "id": "526595ca-3b2e-4b06-9031-0fcfedbd13f1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1754220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 248,
        "selector": "L248-L256",
        "symbol": "TruncBase.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "d8308190-4a22-485d-938a-a491596f3aa5",
  "subject_name": "django/db/models/functions/datetime::TruncBase.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, expression, output_field=None, tzinfo=None, **extra, )"
}
```
