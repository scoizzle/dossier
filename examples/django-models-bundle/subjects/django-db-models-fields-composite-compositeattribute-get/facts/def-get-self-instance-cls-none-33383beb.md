# Fact 33383beb

Store id: 50b186c8-34d8-4748-9567-4386a986acdd

## Text

```text
def __get__(self, instance, cls=None)
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
- posted_at: `2026-11-09T23:31:57.1142730+00:00`

## Data

```json
{
  "end_line": 32,
  "entity_kind": "method",
  "parent": "CompositeAttribute",
  "start_line": 31,
  "symbol": "CompositeAttribute.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":31,"selector":"L31-L32","symbol":"CompositeAttribute.__get__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositeAttribute.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 32,
    "entity_kind": "method",
    "parent": "CompositeAttribute",
    "start_line": 31,
    "symbol": "CompositeAttribute.__get__"
  },
  "id": "50b186c8-34d8-4748-9567-4386a986acdd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1142730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 31,
        "selector": "L31-L32",
        "symbol": "CompositeAttribute.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "d4015201-3e77-47e7-abb7-93e3da7b1292",
  "subject_name": "django/db/models/fields/composite::CompositeAttribute.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
