# Fact 5061076a

Store id: a37e4d6a-1674-473f-aef3-e041b3311f0a

## Text

```text
def __init__( self, verbose_name=None, name=None, max_digits=None, decimal_places=None, **kwargs, )
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
- posted_at: `2026-11-09T23:31:56.6136220+00:00`

## Data

```json
{
  "end_line": 1756,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1747,
  "symbol": "DecimalField.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1747,"selector":"L1747-L1756","symbol":"DecimalField.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1756,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1747,
    "symbol": "DecimalField.__init__"
  },
  "id": "a37e4d6a-1674-473f-aef3-e041b3311f0a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6136220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1747,
        "selector": "L1747-L1756",
        "symbol": "DecimalField.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a0856daf-a5cc-444e-a46c-e35278b4edb2",
  "subject_name": "django/db/models/fields/__init__::DecimalField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, max_digits=None, decimal_places=None, **kwargs, )"
}
```
