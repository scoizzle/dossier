# Fact b88f09bf

Store id: 53279055-42b7-4bc2-85da-559f976ee38b

## Text

```text
def _get_fields( self, forward=True, reverse=True, include_parents=True, include_hidden=False, topmost_call=True, )
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
- posted_at: `2026-11-09T22:39:48.9506230+00:00`

## Data

```json
{
  "end_line": 974,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 881,
  "symbol": "Options._get_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":881,"selector":"L881-L974","symbol":"Options._get_fields"}`

## Items

```json
[
  {
    "text": "Internal helper function to return fields of the model. * If forward=True, then fields defined on this model are returned. * If reverse=True, then relations pointing to this model are returned. * If include_hidden=True, then fields with is_hidden=True are returned. * The include_parents argument toggles if fields from parent models should be included. It has three values: True, False, and PROXY_PARENTS. When set to PROXY_PARENTS, the call will return all fields defined for the current model or any of its parents in the parent chain to the model's concrete model.",
    "locator": {
      "line": 889
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options._get_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 974,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 881,
    "symbol": "Options._get_fields"
  },
  "id": "53279055-42b7-4bc2-85da-559f976ee38b",
  "items": [
    {
      "locator": {
        "line": 889
      },
      "text": "Internal helper function to return fields of the model. * If forward=True, then fields defined on this model are returned. * If reverse=True, then relations pointing to this model are returned. * If include_hidden=True, then fields with is_hidden=True are returned. * The include_parents argument toggles if fields from parent models should be included. It has three values: True, False, and PROXY_PARENTS. When set to PROXY_PARENTS, the call will return all fields defined for the current model or any of its parents in the parent chain to the model's concrete model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.9506230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 881,
        "selector": "L881-L974",
        "symbol": "Options._get_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "f19d0d4a-4c68-4188-a30f-5a21538126c5",
  "subject_name": "django/db/models/options::Options._get_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_fields( self, forward=True, reverse=True, include_parents=True, include_hidden=False, topmost_call=True, )"
}
```
