# Fact 982cdd99

Store id: 9fcd734f-270c-4d63-8ba3-b02f2e8213e1

## Text

```text
def _has_contribute_to_class(value)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.5193840+00:00`

## Data

```json
{
  "end_line": 92,
  "entity_kind": "function",
  "parent": "base",
  "start_line": 90,
  "symbol": "_has_contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":90,"selector":"L90-L92","symbol":"_has_contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/base::_has_contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 92,
    "entity_kind": "function",
    "parent": "base",
    "start_line": 90,
    "symbol": "_has_contribute_to_class"
  },
  "id": "9fcd734f-270c-4d63-8ba3-b02f2e8213e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5193840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 90,
        "selector": "L90-L92",
        "symbol": "_has_contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "852befc0-5052-4f6e-92b2-e46d13f5a95f",
  "subject_name": "django/db/models/base::_has_contribute_to_class",
  "tags": [
    "entity:function"
  ],
  "text": "def _has_contribute_to_class(value)"
}
```
