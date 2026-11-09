# Fact faf25725

Store id: 06d211cd-16ce-4a6c-9fb8-084ad6e0e5d7

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.6896050+00:00`

## Data

```json
{
  "end_line": 2758,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2757,
  "symbol": "BinaryField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2757,"selector":"L2757-L2758","symbol":"BinaryField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2758,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2757,
    "symbol": "BinaryField.check"
  },
  "id": "06d211cd-16ce-4a6c-9fb8-084ad6e0e5d7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6896050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2757,
        "selector": "L2757-L2758",
        "symbol": "BinaryField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5a4f3c08-a92d-4541-894a-4175992f9446",
  "subject_name": "django/db/models/fields/__init__::BinaryField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
