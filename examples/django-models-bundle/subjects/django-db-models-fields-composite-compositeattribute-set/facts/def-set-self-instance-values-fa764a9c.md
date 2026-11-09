# Fact fa764a9c

Store id: 747c9bfa-cef8-456c-a687-e0661730e331

## Text

```text
def __set__(self, instance, values)
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
- posted_at: `2026-11-09T23:44:50.4764920+00:00`

## Data

```json
{
  "end_line": 47,
  "entity_kind": "method",
  "parent": "CompositeAttribute",
  "start_line": 34,
  "symbol": "CompositeAttribute.__set__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":34,"selector":"L34-L47","symbol":"CompositeAttribute.__set__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositeAttribute.__set__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 47,
    "entity_kind": "method",
    "parent": "CompositeAttribute",
    "start_line": 34,
    "symbol": "CompositeAttribute.__set__"
  },
  "id": "747c9bfa-cef8-456c-a687-e0661730e331",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4764920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 34,
        "selector": "L34-L47",
        "symbol": "CompositeAttribute.__set__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "12ce4243-3577-4b2d-a875-ef629e4e4ee5",
  "subject_name": "django/db/models/fields/composite::CompositeAttribute.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, values)"
}
```
