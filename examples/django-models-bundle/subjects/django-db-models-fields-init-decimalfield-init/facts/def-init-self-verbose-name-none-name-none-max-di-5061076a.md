# Fact 5061076a

Store id: e2c5b357-dfd2-46b9-9cc9-c0523b648efc

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
- posted_at: `2026-11-09T22:39:42.4444580+00:00`

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
  "id": "e2c5b357-dfd2-46b9-9cc9-c0523b648efc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4444580+00:00"
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
  "subject_id": "0936f60b-32f9-482b-a80f-1c86bec027b8",
  "subject_name": "django/db/models/fields/__init__::DecimalField.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, verbose_name=None, name=None, max_digits=None, decimal_places=None, **kwargs, )"
}
```
