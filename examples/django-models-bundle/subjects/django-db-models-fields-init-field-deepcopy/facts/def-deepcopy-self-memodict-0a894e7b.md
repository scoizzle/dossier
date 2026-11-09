# Fact 0a894e7b

Store id: 6c72249c-6c89-427a-902a-eb821491bea7

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
- posted_at: `2026-11-09T22:39:42.3029810+00:00`

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
  "id": "6c72249c-6c89-427a-902a-eb821491bea7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3029810+00:00"
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
  "subject_id": "cad6afbf-40c4-43f3-9eb8-99f9b236857d",
  "subject_name": "django/db/models/fields/__init__::Field.__deepcopy__",
  "tags": [
    "entity:method"
  ],
  "text": "def __deepcopy__(self, memodict)"
}
```
