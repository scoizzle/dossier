# Fact 0a894e7b

Store id: 5d28ea48-5cd9-4cd2-8d4b-6c9f13652407

## Text

```text
def __deepcopy__(self, memodict)
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
- posted_at: `2026-11-09T23:44:49.9971300+00:00`

## Data

```json
{
  "end_line": 754,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 745,
  "symbol": "Field.__deepcopy__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":745,"selector":"L745-L754","symbol":"Field.__deepcopy__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__deepcopy__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 754,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 745,
    "symbol": "Field.__deepcopy__"
  },
  "id": "5d28ea48-5cd9-4cd2-8d4b-6c9f13652407",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9971300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 745,
        "selector": "L745-L754",
        "symbol": "Field.__deepcopy__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "d6ff8993-3b4b-401d-98ae-8cea40e42e62",
  "subject_name": "django/db/models/fields/__init__::Field.__deepcopy__",
  "tags": [
    "entity:method"
  ],
  "text": "def __deepcopy__(self, memodict)"
}
```
